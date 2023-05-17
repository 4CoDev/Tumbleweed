using DotGod.Geometry.Spatial.Graphical.Meshes;
using DotGod.Nodes.BatchMaps.Spatial.Spaces;
using Godot;
using Tumbleweed.Nullables;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities;

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