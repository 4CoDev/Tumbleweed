using System = System;
using Nullable = Tumbleweed.Scalar.Nullable;
using Godot = Godot;
using GraphicalGeometry = DotGod.Geometry.Spatial.Concave.Graphical.Mesh;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity;

public abstract class Envelope : Any
{
	protected Envelope(Any entity) =>
		this.entity = entity;

	public override Boolean Equals
	(
		System::Object? @object
	) =>
	(
		entity.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		entity.GetHashCode();

	public override System::String? ToString() =>
		entity.ToString();

	public Nullable::Any<Godot::Node> Node =>
		entity.Node;

	public GraphicalGeometry::Any Mesh =>
		entity.Mesh;

	public Tumbleweed.Geometry.Spatial.Aabb.Any Aabb =>
		entity.Aabb;

	private readonly Any entity;
}