using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Stereometry.Graphical.Mesh.From.Godot;

public sealed class One : Envelope
{
	public One(global::Godot.Mesh mesh) : this
	(
		new Value<global::Godot.Mesh>(mesh)
	)
	{
	}
	
	public One(Any<global::Godot.Mesh> mesh) : this
	(
		new ArrayMesh.From.Mesh.One(mesh)
	)
	{
	}
	
	public One(global::Godot.ArrayMesh mesh) : this
	(
		new Value<global::Godot.ArrayMesh>(mesh)
	)
	{
	}
	
	public One(Any<global::Godot.ArrayMesh> mesh) : base
	(
		new With.Surfaces.One(
			new ArrayMesh.Surface.Enumerable(mesh))
	)
	{
	}
}