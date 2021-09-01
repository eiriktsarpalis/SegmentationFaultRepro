namespace ClassLibrary

// F# equivalent of `public delegate FieldType Getter<DeclaringType, FieldType>(in DeclaringType);`
type Getter<'DeclaringType, 'FieldType> = delegate of inref<'DeclaringType> -> 'FieldType 

type GetterWrapper<'DeclaringType, 'FieldType> (getter : Getter<'DeclaringType, 'FieldType>) =
    member _.Get (instance : 'DeclaringType) = getter.Invoke &instance