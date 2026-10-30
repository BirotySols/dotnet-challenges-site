# .NET Challenges catalog

The static Astro catalog is published at
<https://birotysols.github.io/dotnet-challenges-site/>. Learners need only Git and
the .NET SDK; Node.js is used to develop and build the catalog.

## Local development

```sh
npm ci
npm run dev
npm run build
```

The first release is being delivered one challenge at a time. The reference
solution for HTTP API contracts lives in `reference-solutions/request-validation/`.
The exercise repository's maintainer check copies those files over the naive
starter and runs the same harness.

GitHub Actions builds the static site and deploys it to GitHub Pages after
changes reach `main`.
