# OutSystems Developer Cloud Slugify External Logic Library

With this external logic library you can generate slug / clean URLs from a give text. It is based on
the [Slugify](https://github.com/ctolkien/Slugify) library by [ctolkien](https://github.com/ctolkien).

The **GenerateSlug** action takes the following arguments

* `source` Source text to generate a slug from
* `forceLowerCase` This specifies whether the output string should be converted to lower-case. If set to false, the original casing will be preserved. The lower-case conversion happens before any other character replacements are being made.
* `collapseWhiteSpace` This specifies whether consecutive whitespace should be replaced by just one space (&quot; &quot;). The whitespace will be collapsed before any other character replacements are being made.
* `trimWhiteSpace` This specifies whether leading and trailing whitespace should be removed from the input string. The whitespace will be trimmed before any other character replacements are being made.
* `collapseDashes` This specifies wehther consecutive dashes (&quot;-&quot;) should be collapsed into a single dash. This is useful to avoid scenarios like &quot;foo &amp; bar&quot; becoming &quot;foo--bar&quot;. Dashes will be collapsed after all other string replacements have been made before the final result string is returned.

returns the generated `slug`