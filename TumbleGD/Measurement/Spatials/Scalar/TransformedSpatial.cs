using Godot;
using TumbleGD.Transforms;
using Tumbleweed.Measurement.Spatials;
using Tumbleweed.Scalars;

namespace TumbleGD.Measurement.Spatials.Scalar;

public sealed class TransformedSpatial : IScalar<ISpatial<float>>
{
	public TransformedSpatial
	(
		ISpatial<float> spatial,
		IScalar<Transform3D> transform
	)
	{
		this.spatial = spatial;
		this.transform = transform;
	}
	
	public ISpatial<float> Value()
	{
		return new Tumbleweed.Measurement.Spatials.SpatialFromVector3(
			new TranslatedTransform3DTo(spatial, transform).Value().origin);
	}
	
	private readonly ISpatial<float> spatial;
	
	private readonly IScalar<Transform3D> transform;
}