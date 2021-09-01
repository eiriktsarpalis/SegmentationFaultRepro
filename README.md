# SegmentationFaultRepro

To reproduce
```bash
$ cd ConsoleApp && dotnet run -c release
Fatal error. Internal CLR error. (0x80131506)
   at System.Array.GetEnumerator()
   at Program.<Main>$(System.String[])
Segmentation fault
```
