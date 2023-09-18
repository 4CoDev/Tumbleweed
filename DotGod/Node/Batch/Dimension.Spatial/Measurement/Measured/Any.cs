using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;

public interface Any : Batch::Unmeasured.Any
{
	Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Any Aabb { get; }
}