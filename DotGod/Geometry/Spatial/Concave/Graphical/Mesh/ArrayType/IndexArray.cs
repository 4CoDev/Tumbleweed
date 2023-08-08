using Tumbleweed.Number.Integer.System.Medium.From;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Mesh.ArrayType;

public sealed class IndexArray : Envelope<Int32>
{
	public IndexArray() : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<Int32>(
			new Long(
				new Tumbleweed.Object.Unpacked<Int64>(
					Godot.Mesh.ArrayType.Index)))
	)
	{
	}
}