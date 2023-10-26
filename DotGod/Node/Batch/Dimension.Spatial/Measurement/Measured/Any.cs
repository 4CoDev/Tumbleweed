using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement;
using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;

public interface Any : Batch::Unmeasured.Any
{
	Aabb::Any Aabb { get; }
}