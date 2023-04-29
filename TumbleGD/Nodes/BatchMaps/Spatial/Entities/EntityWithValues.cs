using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using TumbleGD.Nodes.BatchMaps.Spatial.Entities.Equality;
using TumbleGD.Nodes.BatchMaps.Spatial.Occupation;
using Tumbleweed.Hashes;
using Tumbleweed.Nullability;
using Tumbleweed.Strings.FromObjects;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Entities;

public sealed class EntityWithValues : ISpatialEntity
{
	public EntityWithValues
	(
		INullable<Node> node,
		IMesh mesh, 
		IOccupiedSpace size
	)
	{
		Node = node;
		Mesh = mesh;
		Occupation = size;
	}

	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public INullable<Node> Node { get; }

	public IMesh Mesh { get; }

	public IOccupiedSpace Occupation { get; }
}