dists=( \
    "aarch64-apple-darwin" \
    # "aarch64-linux-gnu" \
    # "aarch64-linux-musl" \
    # "aarch64-unknown-freebsd" \
    # "armv6l-linux-gnueabihf" \
    # "armv6l-linux-musleabihf" \
    # "armv7l-linux-gnueabihf" \
    # "armv7l-linux-musleabihf" \
    # "i686-linux-gnu" \
    # "i686-linux-musl" \
    # "i686-w64-mingw32" \
    # "powerpc64le-linux-gnu" \
    "x86_64-apple-darwin" \
    "x86_64-linux-gnu" \
    # "x86_64-linux-musl" \
    # "x86_64-unknown-freebsd" \
    "x86_64-w64-mingw32" \
)

mkdir lib
cd lib

for dist in ${dists[@]}
do
    rm "GLPK.v5.0.1.$dist.tar.gz"
    rm -rf GLPK-$dist
    mkdir GLPK-$dist
    wget "https://github.com/JuliaBinaryWrappers/GLPK_jll.jl/releases/download/GLPK-v5.0.1+1/GLPK.v5.0.1.$dist.tar.gz"
    tar -x -f  "GLPK.v5.0.1.$dist.tar.gz" -C GLPK-$dist
    rm "GLPK.v5.0.1.$dist.tar.gz"

    rm "GMP.v6.3.0.$dist.tar.gz"
    rm -rf GMP-$dist
    mkdir GMP-$dist
    wget "https://github.com/JuliaBinaryWrappers/GMP_jll.jl/releases/download/GMP-v6.3.0+3/GMP.v6.3.0.$dist.tar.gz"
    tar -x -f  "GMP.v6.3.0.$dist.tar.gz" -C GMP-$dist
    wget "https://github.com/JuliaBinaryWrappers/GMP_jll.jl/releases/download/GMP-v6.3.0+3/GMP.v6.3.0.$dist-cxx11.tar.gz"
    tar -x -f  "GMP.v6.3.0.$dist-cxx11.tar.gz" -C GMP-$dist
    mv GMP-$dist/lib/* GLPK-$dist/lib
    rm -rf GMP-$dist
    rm "GMP.v6.3.0.$dist.tar.gz"
    rm "GMP.v6.3.0.$dist-cxx11.tar.gz"
done
