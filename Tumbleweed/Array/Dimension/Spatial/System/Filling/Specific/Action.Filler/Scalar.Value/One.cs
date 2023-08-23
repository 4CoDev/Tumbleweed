using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.Specific.Action.Filler.Scalar.Value;

public sealed class One<T> : Procedure::Envelope
{
	public One
	(
		T[,,] array,
		Scalar::Any<T> filler
	) : this
	(
		new Scalar::With.Value<T[,,]>(array),
		filler
	)
	{
	}
	
	public One
	(
		Scalar::Any<T[,,]> array,
		Scalar::Any<T> filler
	) : base
	(
		new Procedure::From.System(
			() => Procedure(array, filler))
	)
	{
	}

	private static void Procedure
	(
		Scalar::Any<T[,,]> array,
		Scalar::Any<T> filler
	)
	{
		Procedure(array.Value, filler);
	}
	
	private static void Procedure
	(
		T[,,] array,
		Scalar::Any<T> filler
	)
	{
		for (Int32 x = 0; x < array.GetLength(0); x++)
		for (Int32 y = 0; y < array.GetLength(1); y++)
		for (Int32 z = 0; z < array.GetLength(2); z++)
			array[x, y, z] = filler.Value;
	}
}