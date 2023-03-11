using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using TumbleGD.Geometrics.Graphical.Surfaces;
using TumbleGD.Nodes.Spaces.Spatial.Entities.Equality;
using Tumbleweed.Hashes;
using Tumbleweed.Nullability;
using Tumbleweed.Strings.FromObjects;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities;

public sealed class EntityWithValues : ISpatialEntity
{
	public EntityWithValues(INullable<Node> node, IMesh mesh)
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

	public INullable<Node> Node { get; }

	public IMesh Mesh { get; }
}