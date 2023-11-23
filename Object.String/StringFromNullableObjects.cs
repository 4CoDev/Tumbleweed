using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.String;
using String = Tumbleweed.String;
using Tumbleweed.String.From.System.NonNullable;
using Envelope = Tumbleweed.String.Envelope;

namespace Tumbleweed.Object.String;

public sealed class StringFromNullableObjects : String::Envelope
{
	public StringFromNullableObjects(params System.Object?[] objects) : this
	(
		new Concatenated<System.Object?>(objects)
	)
	{
	}
	
	public StringFromNullableObjects(IEnumerable<System.Object?> objects) : base
	(
		new String::Operation.Conсatenated(
			new CommaSeparated(
				new SparesWhenObjectsIsNull(objects, "null")),
			new One("."))
	)
	{
	}
}