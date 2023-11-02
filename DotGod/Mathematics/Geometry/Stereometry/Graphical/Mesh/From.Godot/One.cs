using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.From.Godot;

public sealed class One : Envelope
{
	public One(global::Godot.Mesh mesh) : this
	(
		new One<global::Godot.Mesh>(mesh)
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
		new One<global::Godot.ArrayMesh>(mesh)
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