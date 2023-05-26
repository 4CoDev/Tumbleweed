using Tumbleweed.Number.Integer.Signed.OfSystem._Int32;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Mesh.ArrayType;

public sealed class IndexArray : ScalarEnvelope<Int32>
{
	public IndexArray() : base
	(
		new LazyValue<Int32>(
			new Int32From64(
				new ObjectAsType<Int64>(
					Godot.Mesh.ArrayType.Index)))
	)
	{
	}
}