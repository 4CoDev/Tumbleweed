namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;

public interface Any : Unmeasured.Any
{
	Tumbleweed.Geometry.Spatial.Aabb.Any Aabb { get; }
}