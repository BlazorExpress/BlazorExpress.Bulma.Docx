﻿namespace BlazorExpress.Bulma.Docx
{
    /// <summary>
    /// Extension methods for <see cref="PropertyInfo" />.
    /// </summary>
    public static class PropertyInfoExtenstions
    {
        /// <summary>
        /// Get event callback return type.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns>Returns list of component event callbacks.</returns>
        public static string GetEventCallbackReturnType(this PropertyInfo propertyInfo)
        {
            HashSet<string> arguments = new();
            if (propertyInfo.PropertyType.IsGenericType)
            {
                Type[] genericArguments = propertyInfo.PropertyType.GetGenericArguments();
                if (genericArguments.Length > 0)
                {
                    foreach (Type genericArgument in genericArguments)
                        arguments.Add(genericArgument.GetCSharpTypeName());
                }
            }

            return arguments.Count > 0 ? $"EventCallback<{string.Join(",", arguments)}>" : "EventCallback";
        }

        /// <summary>
        /// Get parameter type name.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns>string</returns>
        public static string GetParameterTypeName(this PropertyInfo propertyInfo)
        {
            var parameterTypeNameAttribute = propertyInfo.GetCustomAttributes(typeof(ParameterTypeNameAttribute), false).FirstOrDefault() as ParameterTypeNameAttribute;
            return parameterTypeNameAttribute?.TypeName ?? null!;
        }

        /// <summary>
        /// Get added version of a property.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns>string</returns>
        public static string GetPropertyAddedVersion(this PropertyInfo propertyInfo)
        {
            var addedVersionAttribute = propertyInfo.GetCustomAttributes(typeof(AddedVersionAttribute), false).FirstOrDefault() as AddedVersionAttribute;
            return addedVersionAttribute?.Version!;
        }

        /// <summary>
        /// Get default value of a property.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns>string</returns>
        public static string GetPropertyDefaultValue(this PropertyInfo propertyInfo)
        {
            var defaultValueAttribute = propertyInfo.GetCustomAttributes(typeof(DefaultValueAttribute), false).FirstOrDefault() as DefaultValueAttribute;
            return defaultValueAttribute?.Value?.ToString() ?? "null";
        }

        /// <summary>
        /// Get property description.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns>string</returns>
        public static string GetPropertyDescription(this PropertyInfo propertyInfo)
        {
            var descriptionAttribute = propertyInfo.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            return descriptionAttribute?.Description ?? string.Empty;
        }

        /// <summary>
        /// Get property type name.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns>string</returns>
        public static string GetPropertyTypeName(this PropertyInfo propertyInfo)
        {
            var propertyTypeName = propertyInfo.Name;
            if (string.IsNullOrWhiteSpace(propertyTypeName))
                return string.Empty;

            if (propertyTypeName.Contains(BlazorExpress.Bulma.StringConstants.PropertyTypeNameInt16, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameInt16CSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameInt32, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameInt32CSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameInt64, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameInt64CSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameChar, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameCharCSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameStringComparison, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameStringComparisonCSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameString, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameStringCSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameSingle, StringComparison.InvariantCulture)) // float
                propertyTypeName = StringConstants.PropertyTypeNameSingleCSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameDecimal, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameDecimalCSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameDouble, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameDoubleCSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameDateOnly, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameDateOnlyCSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameDateTime, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameDateTimeCSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameBoolean, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameBooleanCSharpTypeKeyword;

            //else if (propertyType!.IsEnum)
            //    propertyTypeName = StringConstants.PropertyTypeNameEnumCSharpTypeKeyword;

            else if (propertyTypeName.Contains(StringConstants.PropertyTypeNameGuid, StringComparison.InvariantCulture))
                propertyTypeName = StringConstants.PropertyTypeNameGuidCSharpTypeKeyword;

            return propertyTypeName;
        }

        /// <summary>
        /// Determines whether the specified property is an EventCallback or EventCallback&lt;T&gt;.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns>bool</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool IsEventCallbackProperty(this PropertyInfo propertyInfo)
        {
            if (propertyInfo == null)
            {
                throw new ArgumentNullException(nameof(propertyInfo));
            }

            // Check for EventCallback
            if (propertyInfo.PropertyType == typeof(EventCallback))
            {
                return true;
            }

            // Check for EventCallback<T>
            if (propertyInfo.PropertyType.IsGenericType &&
                propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(EventCallback<>))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the property is required. Otherwise, false.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns>bool</returns>
        public static bool IsPropertyRequired(this PropertyInfo propertyInfo)
        {
            var editorRequiredAttribute = propertyInfo.GetCustomAttributes(typeof(EditorRequiredAttribute), false).FirstOrDefault() as EditorRequiredAttribute;
            return editorRequiredAttribute is not null;
        }
    }
}

// TODO: Remove this
namespace BlazorExpress.Bulma
{
    public static class StringConstants
    {
        #region Fields and Constants

        public const string Nullable = "Nullable";
        public const string PropertyTypeNameInt16 = "Int16";
        public const string PropertyTypeNameInt32 = "Int32";
        public const string PropertyTypeNameInt64 = "Int64";
        public const string PropertyTypeNameChar = "Char";
        public const string PropertyTypeNameStringComparison = "StringComparison";
        public const string PropertyTypeNameString = "String";
        public const string PropertyTypeNameSingle = "Single"; // float
        public const string PropertyTypeNameDecimal = "Decimal";
        public const string PropertyTypeNameDouble = "Double";
        public const string PropertyTypeNameDateOnly = "DateOnly";
        public const string PropertyTypeNameDateTime = "DateTime";
        public const string PropertyTypeNameBoolean = "Boolean";
        public const string PropertyTypeNameEnum = "Enum";
        public const string PropertyTypeNameGuid = "Guid";

        public const string PropertyTypeNameInt16CSharpTypeKeyword = "short";
        public const string PropertyTypeNameInt32CSharpTypeKeyword = "int";
        public const string PropertyTypeNameInt64CSharpTypeKeyword = "long";
        public const string PropertyTypeNameCharCSharpTypeKeyword = "char";
        public const string PropertyTypeNameStringComparisonCSharpTypeKeyword = "StringComparison";
        public const string PropertyTypeNameStringCSharpTypeKeyword = "string";
        public const string PropertyTypeNameSingleCSharpTypeKeyword = "float";
        public const string PropertyTypeNameDecimalCSharpTypeKeyword = "decimal";
        public const string PropertyTypeNameDoubleCSharpTypeKeyword = "double";
        public const string PropertyTypeNameDateOnlyCSharpTypeKeyword = "DateOnly";
        public const string PropertyTypeNameDateTimeCSharpTypeKeyword = "DateTime";
        public const string PropertyTypeNameBooleanCSharpTypeKeyword = "bool";
        public const string PropertyTypeNameEnumCSharpTypeKeyword = "enum";
        public const string PropertyTypeNameGuidCSharpTypeKeyword = "Guid";

        #endregion
    }
}