using Scalar = Tumbleweed.Scalar;
using Tumbleweed.Mathematics.Boolean;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Bit;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Boolean.Any>
{
	public Enumerable(System::Single single) : this
	(
		new Scalar::Immutable.With.Value
			<System::Single>
			(single)
	)
	{
	}
    
	public Enumerable
	(
		Scalar::Immutable.Any<System::Single> single
	) : base
	(
		new BitsOfBytes(
			new Byte.Enumerable(single))
	)
	{
	}
}