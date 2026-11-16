# Copilot instructions for MongoDBCodeGen

## Project overview
This repository is a minimal MongoDB Playground project for Visual Studio Code. It contains a single focused playground script and workspace settings for MongoDB shell experimentation, not a packaged application.

The main files are:
- `playground-1.mongodb.js` — the primary MongoDB aggregation example using `use('MoviesDatabase')` and `db.Movies.aggregate([...])`.
- `settings.json` — editor configuration for the MongoDB extension.
- `README.md` — minimal repository description.

## Working conventions
- Treat this repo as a MongoDB scripting workspace, not a general backend or web app.
- Prefer JavaScript syntax that works in the MongoDB shell and MongoDB Playground environment.
- Use the global `use(...)` function and `db` object for all collection access.
- Keep scripts self-contained, readable, and runnable in a MongoDB Playground session.
- Follow the existing data-operations style already used in `playground-1.mongodb.js`.

## Code style
- Use clear comments sparingly and only when they add context.
- Prefer direct shell operations such as `db.collection.find(...)`, `db.collection.aggregate([...])`, `db.collection.insertMany(...)`, and `use('DatabaseName')`.
- When writing aggregation pipelines, keep them as an array of stage objects with supported MongoDB operators such as `$match`, `$project`, `$slice`, and `$sort`.
- Preserve the existing simple script style: one database selection, then a focused query or aggregation.
- Favor patterns that map directly to MongoDB Playground examples rather than app frameworks or server code.

## Validation guidance
- There are no package tests or build steps in this repository.
- Validate changes by checking that the script still uses valid MongoDB shell / Playground syntax and that the pipeline remains consistent with the project’s minimal playground structure.
- Do not add unrelated framework tooling, Node packages, or build systems unless a task explicitly requires them.

## Do not do
- Do not treat this as a Node.js or Express project.
- Do not introduce framework-specific patterns or application scaffolding.
- Do not add unrelated test runners, CI configuration, or package manifests.
- Do not convert MongoDB Playground scripts into a different runtime model without explicit request.

## Recommended response behavior for agents
When helping in this repo:
- Keep suggestions grounded in MongoDB shell and Playground behavior.
- Explain examples in terms of `use()`, `db`, collections, filter stages, projection stages, and aggregation pipelines.
- If a task requires a new script, prefer a single focused `.mongodb.js` file that demonstrates the intended MongoDB operation.
- Preserve the repo’s minimal scope and avoid broad refactors or unrelated changes.
