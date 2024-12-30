// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var assetReference = Reference.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));
// var assetReference = Reference.ByExternalId("which-brewing-fits-you");

var response = await client.CreateAssetRenditionAsync(assetReference, new AssetRenditionCreateModel
{
    ExternalId = "hero-image-rendition",
    Transformation = new RectangleResizeTransformation
    {
        CustomWidth = 120,
        CustomHeight = 240,
        X = 300,
        Y = 200,
        Width = 360,
        Height = 720,                    
    }
});
