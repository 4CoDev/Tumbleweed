using Godot;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;

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