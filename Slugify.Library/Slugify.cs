using OutSystems.ExternalLibraries.SDK;
using Slugify;

namespace Without.Systems.Slugify;

public class Slugify : ISlugify
{
    public string GenerateSlug(string text, bool forceLowerCase, bool collapseWhiteSpace, bool trimWhiteSpace,
        bool collapseDashes)
    {
        SlugHelperConfiguration slugHelperConfiguration = new SlugHelperConfiguration
        {
            CollapseDashes = collapseDashes,
            CollapseWhiteSpace = collapseWhiteSpace,
            ForceLowerCase = forceLowerCase,
            TrimWhitespace = trimWhiteSpace
        };
        SlugHelper slugHelper = new SlugHelper(slugHelperConfiguration);
        return slugHelper.GenerateSlug(text);
    }
}