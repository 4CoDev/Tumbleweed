using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using DotGod.Node.Spatial.Batch.Space;
using Tumbleweed.Scalar.Nullable;
using System = System;

namespace DotGod.Node.Spatial.Batch.Entities;

public abstract class EntityEnvelope : ISpatialEntity
{
	protected EntityEnvelope(ISpatialEntity entity) =>
		this.entity = entity;

	public override Boolean Equals(System::Object? @object) =>
		entity.Equals(@object);

	public override Int32 GetHashCode() =>
		entity.GetHashCode();

	public override System::String? ToString() =>
		entity.ToString();

	public Any<Godot.Node> Node => entity.Node;

	public Geometry.Spatial.Concave.Graphical.Mesh.Any Mesh => entity.Mesh;

	public ISpace Occupation => entity.Occupation;

	private readonly ISpatialEntity entity;
}