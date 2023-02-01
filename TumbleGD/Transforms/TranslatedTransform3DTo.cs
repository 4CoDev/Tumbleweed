using Godot;
using Tumbleweed.Measurement.Spatials;
using Tumbleweed.Measurement.Spatials.Scalar;
using Tumbleweed.Scalars;

namespace TumbleGD.Transforms;

public sealed class TranslatedTransform3DTo : IScalar<Transform3D>
{
	public TranslatedTransform3DTo
	(
		ISpatial<float> translation,
		IScalar<Transform3D> transform
	) : this
	(
		new Vector3FromSpatial(translation),
		transform
	)
	{
	}
	
	public TranslatedTransform3DTo
	(
		IScalar<Vector3> translation,
		IScalar<Transform3D> transform)
	{
		this.translation = translation;
		this.transform = transform;
	}
	
	public Transform3D Value()
	{
		return transform.Value().Translated(translation.Value());
	}
	
	private readonly IScalar<Vector3> translation;
	
	private readonly IScalar<Transform3D> transform;
}