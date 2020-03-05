compiler = C:/Windows/Microsoft.NET/Framework64/v4.0.30319/csc.exe

all:	decryptor encryptor

decryptor:
	$(compiler) /t:exe /out:decryptor.exe decryptor.cs

encryptor:
	$(compiler) /t:exe /out:encryptor.exe encryptor.cs

clean:
	rm decryptor.exe encryptor.exe
