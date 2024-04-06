using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.Slugify
{
    [OSInterface(
        Description = "Generate slug and clean URLs",
        IconResourceName = "Without.Systems.Slugify.Resources.Slugify.png")]
    public interface ISlugify
    {
        /// <summary>
        /// Generates a clean URL from a given text
        /// </summary>
        /// <param name="text">Source text to generate a slug from</param>
        /// <param name="forceLowerCase">This specifies whether the output string should be converted to lower-case. If set to false, the original casing will be preserved. The lower-case conversion happens before any other character replacements are being made.</param>
        /// <param name="collapseWhiteSpace">This specifies whether consecutive whitespace should be replaced by just one space (\" \"). The whitespace will be collapsed before any other character replacements are being made.</param>
        /// <param name="trimWhiteSpace">This specifies whether leading and trailing whitespace should be removed from the input string. The whitespace will be trimmed before any other character replacements are being made.</param>
        /// <param name="collapseDashes">This specifies whether consecutive dashes (\"-\") should be collapsed into a single dash. This is useful to avoid scenarios like \"foo & bar\" becoming \"foo--bar\". Dashes will be collapsed after all other string replacements have been made before the final result string is returned.</param>
        /// <returns>Generated slug</returns>
        [OSAction(
            Description = "Generates a clean URL from a given text",
            ReturnName = "slug",
            ReturnDescription = "Generated slug",
            ReturnType = OSDataType.Text,
            IconResourceName = "Without.Systems.Slugify.Resources.Slugify.png")]
        string GenerateSlug(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Source text to generate a slug from")]
            string text,
            [OSParameter(
                DataType = OSDataType.Boolean,
                Description = "This specifies whether the output string should be converted to lower-case. If set to false, the original casing will be preserved. The lower-case conversion happens before any other character replacements are being made.")]
            bool forceLowerCase,
            [OSParameter(
                DataType = OSDataType.Boolean,
                Description = "This specifies whether consecutive whitespace should be replaced by just one space (\" \"). The whitespace will be collapsed before any other character replacements are being made.")]
            bool collapseWhiteSpace,
            [OSParameter(
                DataType = OSDataType.Boolean,
                Description = "This specifies whether leading and trailing whitespace should be removed from the input string. The whitespace will be trimmed before any other character replacements are being made.")]
            bool trimWhiteSpace,
            [OSParameter(
                DataType = OSDataType.Boolean,
                Description = "This specifies whether consecutive dashes (\"-\") should be collapsed into a single dash. This is useful to avoid scenarios like \"foo & bar\" becoming \"foo--bar\". Dashes will be collapsed after all other string replacements have been made before the final result string is returned.")]
            bool collapseDashes);
    }
}