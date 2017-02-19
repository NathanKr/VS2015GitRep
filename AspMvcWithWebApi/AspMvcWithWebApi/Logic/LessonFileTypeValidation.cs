using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.IO;

namespace AspMvcWithWebApi.Logic
{
    /// <summary>
    /// this is attribute on Lesson.File 
    /// it take into account also Lesson.Type
    /// </summary>
    public class LessonFileAttribute : ValidationAttribute
    {
        private string m_fileValue;
        ValidationContext m_validationContext;
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string strExpectedFileType;
            m_fileValue = (string)value;
            m_validationContext = validationContext;

            if (!validationIsValid(out strExpectedFileType))
            {
                return new ValidationResult(string.Format("Expected file type for {0} is {1}",
                    validationContext.DisplayName , strExpectedFileType));
            }

            return ValidationResult.Success;
        }

        private bool validationIsValid(out string strExpectedFileType)
        {
            var containerType = m_validationContext.ObjectInstance.GetType();
            var field = containerType.GetProperty("Type");
            strExpectedFileType = "";

            if (field != null)
            {
                LessonEnums extensionValue = (LessonEnums)field.GetValue(m_validationContext.ObjectInstance, null);

                 switch (extensionValue)
                 {
                     case LessonEnums.Video:
                        // check here for mp4 in m_fileValue
                        return isMp4File(out strExpectedFileType);

                     case LessonEnums.Quiz:
                        // check here for image file
                        return isHtmlFile(out strExpectedFileType);
                 }
            }

            return false;
        }

        private bool fileExtensionEqual(string strExtension)
        {
            return (Path.GetExtension(m_fileValue).ToLower() == "."+strExtension.ToLower());
        }

        private bool isMp4File(out string strExpectedFileType)
        {
            strExpectedFileType = "mp4";
            return fileExtensionEqual(strExpectedFileType);
        }

        private bool isHtmlFile(out string strExpectedFileType)
        {
            strExpectedFileType = "html";
            return fileExtensionEqual(strExpectedFileType); 
        }

    }
}