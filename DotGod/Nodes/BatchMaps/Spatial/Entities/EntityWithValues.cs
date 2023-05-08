using DotGod.Geometrics.Graphical.Meshes;
using DotGod.Nodes.BatchMaps.Spatial.Entities.Equality;
using DotGod.Nodes.BatchMaps.Spatial.Spaces;
using Godot;
using Tumbleweed.Hashes;
using Tumbleweed.Nullability;
using Tumbleweed.Strings.FromObjects;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities;

public sealed class EntityWithValues : ISpatialEntity
{
	public EntityWithValues
	(
		INullable<Node> node,
		IMesh mesh, 
		ISpace size
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

	public ISpace Occupation { get; }
}