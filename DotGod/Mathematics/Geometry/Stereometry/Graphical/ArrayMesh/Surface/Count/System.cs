using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface.
	Count;

public sealed class System : Envelope<Int32>
{
	public System(Any<Godot.ArrayMesh> mesh) : base
	(
		new Actual<Int32>(
			() => mesh.Value.GetSurfaceCount())
	)
	{
	}
}