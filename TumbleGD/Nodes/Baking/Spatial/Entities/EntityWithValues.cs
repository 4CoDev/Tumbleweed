using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using TumbleGD.Nodes.Baking.Spatial.Entities.Equality;
using Tumbleweed.Existence;
using Tumbleweed.Hashes;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromObjects;

namespace TumbleGD.Nodes.Baking.Spatial.Entities;

public sealed class EntityWithValues : IBakingEntity
{
	public EntityWithValues
	(
		IExistence<Node> node,
		IEnumerable<ISurface> mesh
	)
	{
		Node = node;
		Mesh = mesh;
	}

	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new CodeFromObjects(Node, Mesh).Value;

	public override String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public IExistence<Node> Node { get; }

	public IEnumerable<ISurface> Mesh { get; }
}