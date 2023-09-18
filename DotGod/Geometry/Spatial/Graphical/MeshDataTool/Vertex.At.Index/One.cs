using DotGod.Geometry.Spatial.Concave.Graphical.Vertex;
using DotGod.Geometry.Spatial.Graphical.Vertex;
using Godot;
using Tumbleweed.Point.Spatial.Generic;

// ReSharper disable once CheckNamespace
namespace DotGod.Geometry.Spatial.Concave.Graphical.MeshDataTool.Vertex.At;

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

	public Any<Tumbleweed.Number.Real.Any> Translation =>
		new Spatial.Graphical.MeshDataTool.Vertex.At.Index.Translation.As.Point.One(mesh, vertex);

	public Any<Tumbleweed.Number.Real.Any> Normal =>
		new Spatial.Graphical.MeshDataTool.Vertex.At.Index.Normal.As.Point.One(mesh, vertex);

	public Tumbleweed.Scalar.Immutable.Any<Color> Color =>
		new Spatial.Graphical.MeshDataTool.Vertex.At.Index.Color.One(mesh, vertex);

	public Tumbleweed.Point.Planar.Any<Tumbleweed.Number.Real.Any> UV =>
		new Spatial.Graphical.MeshDataTool.Vertex.At.Index.UV.As.Point.One(mesh, vertex);

	private readonly Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> mesh;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<Int32> vertex;
}