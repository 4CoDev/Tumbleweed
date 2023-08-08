using DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Triangle.FromGodot.FromSurface;
using DotGod.Geometry.Spatial.Concave.Graphical.Surface;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.Surface.At.Index;

public sealed class One : Envelope
{
	public One
	(
		Any<Godot.ArrayMesh> mesh,
		Int32 index
	) : this
	(
		mesh, new Value<Int32>(index)
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