all: build run

clean:
	-@rm main.exe

build:
	-@mcs main.cs
run:
	-@mono main.exe
