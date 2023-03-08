using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using TumbleGD.Nodes.Baking.Spatial.Entities.Equality;
using Tumbleweed.Existence;
using Tumbleweed.Hashes;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromObjects;

namespace TumbleGD.Nodes.Baking.Spatial.Entities;

public sealed class EntityOfScalar : IBakingEntity
{
	public EntityOfScalar(IScalar<IBakingEntity> scalar) =>
		this.scalar = scalar;
	
	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new CodeFromObjects(Node, Mesh).Value;

	public override String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public IExistence<Node> Node =>
		scalar.Value.Node;

	public IEnumerable<ISurface> Mesh =>
		scalar.Value.Mesh;

	private readonly IScalar<IBakingEntity> scalar;
}