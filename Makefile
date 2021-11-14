.PHONY: clean runAll

clean:
	rm -rf */bin

runAll:
	find . -maxdepth 1 -type d \( ! -name . \) -exec bash -c "cd '{}' && pwd && dotnet run" \;