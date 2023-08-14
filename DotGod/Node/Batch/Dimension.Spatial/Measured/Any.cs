namespace DotGod.Node.Batch.Dimension.Spatial.Measured;

public interface Any : Unmeasured.Any
{
	Tumbleweed.Geometry.Spatial.Aabb.Any Aabb { get; }
}