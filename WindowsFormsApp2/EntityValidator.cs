﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class EntityValidator : IDataErrorInfo
    {
        [Browsable(false)]
        public string this[string property]
        {
            get
            {
                var propertyDescriptor = TypeDescriptor.GetProperties(this)[property];
                if (propertyDescriptor == null)
                    return String.Empty;
                var results = new List<ValidationResult>();
                var result = Validator.TryValidateProperty(propertyDescriptor.GetValue(this), new ValidationContext(this, null, null)
                { MemberName= property}, results);

                if (!result)
                    return results.First().ErrorMessage;
                return string.Empty;
            }
        }
        [Browsable(false)]
        public string Error
        {
            get
            {
                var results = new List<ValidationResult>();
                var result = Validator.TryValidateObject(this, new ValidationContext(this, null, null), results, true);
                if(!result)
                    return String.Join(Environment.NewLine, results.Select(x => x.ErrorMessage));
                return null;
            }
        }
        [Browsable(false)]
        public bool IsValid => string.IsNullOrEmpty(Error);
    }
}
