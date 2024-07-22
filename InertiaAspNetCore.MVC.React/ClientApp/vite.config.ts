import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";
import laravel from "laravel-vite-plugin";
import path from "path";
import { mkdirSync } from "fs";

// Auto-initialize the default output directory
const outDir = "../wwwroot/build";

mkdirSync(outDir, { recursive: true });

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [
        laravel({
            input: ["src/App.tsx"],
            publicDirectory: outDir,
        }),
        react(),
    ],
    resolve: {
        alias: {
            "@": path.resolve(__dirname, "src"),
        },
    },
    build: {
        outDir,
        emptyOutDir: true,
    },
});