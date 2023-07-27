using DotGod.Spatial._Node.Batch.Space;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed.Nullable;
using System = System;

namespace DotGod.Spatial._Node.Batch.Entities;

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

	public IMesh Mesh => entity.Mesh;

	public ISpace Occupation => entity.Occupation;

	private readonly ISpatialEntity entity;
}