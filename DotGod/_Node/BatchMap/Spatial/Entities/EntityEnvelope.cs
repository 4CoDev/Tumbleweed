using DotGod._Node.BatchMap.Spatial.Spaces;
using DotGod.Geometry.Spatial.Graphical._Mesh;
using Godot;
using Tumbleweed.Nullable;

namespace DotGod._Node.BatchMap.Spatial.Entities;

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