using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace StarWarsApi.Domain.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Get only numeric (0-9) chars from a string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetNumerics(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            string response = string.Empty;
            var pattern = @"\d+";
            Regex regex = new Regex(pattern);

            var result = regex.Match(value);

            if (result.Success)
                response = result.Value;

            return response;
        }


        /// <summary>
        /// Return a string with only numerics characters (positive or negative)
        /// </summary>
        /// <param name="value">string in use</param>
        /// <returns>numerics characters</returns>
        public static string GetInteger(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            string response = string.Empty;
            var pattern = @"(-?)\d+";
            Regex regex = new Regex(pattern);

            var results = regex.Matches(value);

            if (results.Count > 0)
            {
                foreach (Match result in results)
                {
                    response += result.Value;
                }
            }

            return response;
        }

        public static string SubstituteSpecialChars(this string value)
        {
            var normalizedString = value.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder(capacity: normalizedString.Length);

            for (int i = 0; i < normalizedString.Length; i++)
            {
                char c = normalizedString[i];
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            var response = stringBuilder
                .ToString()
                .Normalize(NormalizationForm.FormC);

            response = response.Replace("'", " ");

            return response;

        }
    }
}

