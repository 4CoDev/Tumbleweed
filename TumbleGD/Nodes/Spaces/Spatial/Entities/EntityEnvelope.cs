using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Existence;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities;

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

	public IExistence<Node> Node => entity.Node;

	public IEnumerable<ISurface> Mesh => entity.Mesh;
	
	private readonly ISpatialEntity entity;
}