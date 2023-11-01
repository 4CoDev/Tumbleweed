using Godot;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;

namespace DotGod.Transform.Spatial.Origin.Vector;

public sealed class One : Envelope<Vector3>
{
	public One(Any<Transform3D> transform) : base
	(
		new Actual<Vector3>(
			() => transform.Value.Origin)
	)
	{
	}
}