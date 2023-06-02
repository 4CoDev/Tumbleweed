using DotGod.Spatial._Node.Batch.Spaces;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Tumbleweed.Nullable;

namespace DotGod.Spatial._Node.Batch.Entities;

public abstract class EntityEnvelope : ISpatialEntity
{
	protected EntityEnvelope(ISpatialEntity entity) =>
		this.entity = entity;

	public override Boolean Equals(Object? @object) =>
		entity.Equals(@object);

	public override Int32 GetHashCode() =>
		entity.GetHashCode();

	public override String? ToString() =>
		entity.ToString();

	public INullable<Node> Node => entity.Node;

	public IMesh Mesh => entity.Mesh;

	public ISpace Occupation => entity.Occupation;

	private readonly ISpatialEntity entity;
}