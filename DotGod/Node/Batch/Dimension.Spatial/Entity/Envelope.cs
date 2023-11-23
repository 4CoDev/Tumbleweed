using System = System;
using Option = Tumbleweed.Property.Option;
using Godot = Godot;

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

	public Option::Any<Godot::Node> Node =>
		entity.Node;

	public Mathematics.Geometry.Stereometry.Graphical.Mesh.Any Mesh =>
		entity.Mesh;

	public Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any Aabb =>
		entity.Aabb;

	private readonly Any entity;
}