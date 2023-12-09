import os
import shutil
import sys
from pathlib import Path


template_file_path: Path = Path("./Program.cs")
src_directory_path: Path = Path("../src")
test_directory_path: Path = Path("../test")

CSHARP_INDENT = " " * 4

if __name__ == '__main__':
    commandline_args = sys.argv
    if len(commandline_args) < 2:
        print("第一引数にURLを入力してください")
        exit(-1)

    atcoder_url = commandline_args[1]
    print(atcoder_url)

    package_name = atcoder_url.split("/")[-1].replace("_", "/")
    new_package_directory = f"{src_directory_path}/{package_name}"
    os.makedirs(new_package_directory, exist_ok=True)

    src_namespace_text = f"namespace src.{package_name.replace('/', '.')};"
    test_headers = [
        f"namespace test.{package_name.replace('/', '.')}",
        "{",
        CSHARP_INDENT + f"using src.{package_name.replace('/', '.')};",
        "}"
    ]

    src_code = src_namespace_text + os.linesep + template_file_path.read_text()

    # ソースコード
    src_file_name = os.path.basename(template_file_path)
    new_file_path = src_directory_path.joinpath(package_name).joinpath(src_file_name)
    if not new_file_path.exists():
        new_file_path.write_text(src_code)

    # テストコード
    template_file_name_elements = os.path.basename(template_file_path).split(".")
    test_file_name = template_file_name_elements[0] + "Test." + template_file_name_elements[1]
    new_test_file_path = test_directory_path.joinpath(package_name).joinpath(test_file_name)

    new_test_file_path.parent.mkdir(exist_ok=True, parents=True)
    if not new_test_file_path.exists():
        new_test_file_path.write_text(os.linesep.join(test_headers))
        print(os.linesep.join(test_headers))
