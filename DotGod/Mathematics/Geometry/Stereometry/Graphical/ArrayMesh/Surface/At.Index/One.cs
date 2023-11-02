using DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon.Triangle.FromGodot.FromSurface;
using DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index;

public sealed class One : Envelope
{
	public One
	(
		Any<Godot.ArrayMesh> mesh,
		Int32 index
	) : this
	(
		mesh, new One<Int32>(index)
	)
	{
	}
	
	public One
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> index
	) : base
	(
		new Graphical.Surface.With.Members.One(
			new TrianglesOfSurface(mesh, index),
			new Material.One(mesh, index))
	)
	{
	}
}