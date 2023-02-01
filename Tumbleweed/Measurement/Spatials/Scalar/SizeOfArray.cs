using Tumbleweed.Scalars;

namespace Tumbleweed.Measurement.Spatials.Scalar;

public sealed class SizeOfArray : IScalar<ISpatial<int>>
{
	public SizeOfArray(Array array)
	{
		this.array = array;
	}
	
	public ISpatial<int> Value()
	{
		return new Spatial<int>(
			array.GetLength(0),
			array.GetLength(1),
			array.GetLength(2));
	}

	private readonly Array array;
}