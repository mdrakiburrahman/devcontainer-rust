

## Things to try

Once you have this sample opened, you'll be able to work with it like you would locally.

Some things to try:

1. **Edit:**
   - Open `main.rs`
   - Try adding some code and check out the language features.
   - Make a spelling mistake and notice it is detected. The [Code Spell Checker](https://marketplace.visualstudio.com/items?itemName=streetsidesoftware.code-spell-checker) extension was automatically installed because it is referenced in `.devcontainer/devcontainer.json`.
   - Also notice that utilities like `rls` and the [Rust Analyzer](https://marketplace.visualstudio.com/items?itemName=rust-lang.rust-analyzer) extension are installed. Tools are installed in the `mcr.microsoft.com/devcontainers/rust` image and Dev Container settings and metadata are automatically picked up from [image labels](https://containers.dev/implementors/reference/#labels).

To build a DLL for windows:

```bash
rustup target add x86_64-pc-windows-gnu
sudo apt-get update
sudo apt-get install mingw-w64
```

1. **Terminal:** Press <kbd>ctrl</kbd>+<kbd>shift</kbd>+<kbd>\`</kbd> and type `uname` and other Linux commands from the terminal window.

1. **Build, Run, and Debug:**
   - Open `main.rs`
   - Add a breakpoint (e.g. on line 8).
   - Press <kbd>F5</kbd> to launch the app in the container.
   - Once the breakpoint is hit, try hovering over variables, examining locals, and more.

1. **Use `cargo`**
   - Clean: `cargo clean`
   - Build: `cargo build`
   - Run: `cargo run`
   - Build DLL: `cargo build --lib --target x86_64-pc-windows-gnu`. DLL is available here: `target/x86_64-pc-windows-gnu/debug/hallo.dll`
