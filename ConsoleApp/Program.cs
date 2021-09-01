using ClassLibrary;

GetterWrapper<MyRecord, int[]> wrapper = new((in MyRecord record) => record.Value);

MyRecord record = new MyRecord(new int[] { 42 });
int[] value = wrapper.Get(record);
value.GetEnumerator(); // segmentation fault

public record MyRecord(int[] Value);