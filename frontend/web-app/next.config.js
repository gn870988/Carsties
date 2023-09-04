/** @type {import('next').NextConfig} */

const nextConfig = {
  experimental: {
    logging: "verbose",
  },
  experimental: {
    serverActions: true,
  },
  images: {
    domains: ["cdn.pixabay.com"],
  },
};

module.exports = nextConfig;
