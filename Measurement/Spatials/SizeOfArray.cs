namespace Tumbleweed.Measurement.Spatials;

public sealed class SizeOfArray : SpatialEnvelope<int>
{
	public SizeOfArray(Array array) : base
	(
		new SpatialFromScalar<int>(
			new Scalar.SizeOfArray(array))
	)
	{
	}
}