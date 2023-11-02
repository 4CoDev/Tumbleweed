using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Mantissa;

public sealed class Length : Envelope<Int32>
{
	public Length() : base
	(
		new One<Int32>(52)
	)
	{
	}
}