using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Transform.Spatial.Translated.By.Vector;

public sealed class One : Envelope<Transform3D>
{
	public One
	(
		Any<Transform3D> transform,
		Any<Vector3> translation
	) : base
	(
		new Actual<Transform3D>(
			() => transform.Value.Translated(translation.Value))
	)
	{
	}
}