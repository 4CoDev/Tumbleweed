using DotGod.Geometry.Stereometry.Concave.Graphical.Vertex;
using DotGod.Geometry.Stereometry.Graphical.Vertex;
using Godot;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

// ReSharper disable once CheckNamespace
namespace DotGod.Geometry.Stereometry.Concave.Graphical.MeshDataTool.Vertex.At;

public sealed class One : Any
{
	public One
	(
		Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> mesh,
		Tumbleweed.Scalar.Immutable.Any<Int32> vertex
	)
	{
		this.mesh = mesh;
		this.vertex = vertex;
	}

	public Any<Tumbleweed.Mathematics.Number.Real.Any> Translation =>
		new Stereometry.Graphical.MeshDataTool.Vertex.At.Index.Translation.As.Point.One(mesh, vertex);

	public Any<Tumbleweed.Mathematics.Number.Real.Any> Normal =>
		new Stereometry.Graphical.MeshDataTool.Vertex.At.Index.Normal.As.Point.One(mesh, vertex);

	public Tumbleweed.Scalar.Immutable.Any<Color> Color =>
		new Stereometry.Graphical.MeshDataTool.Vertex.At.Index.Color.One(mesh, vertex);

	public Tumbleweed.Mathematics.Vector.Planar.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> UV =>
		new Stereometry.Graphical.MeshDataTool.Vertex.At.Index.UV.As.Point.One(mesh, vertex);

	private readonly Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> mesh;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<Int32> vertex;
}