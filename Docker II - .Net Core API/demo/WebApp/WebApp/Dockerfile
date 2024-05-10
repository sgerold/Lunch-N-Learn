FROM node:19-alpine as build-step
RUN mkdir -p /app
WORKDIR /app
COPY package.json /app

RUN npm install
COPY . /app
RUN npm run build 

FROM nginx:1.23.2-alpine
COPY --from=build-step /app/dist/web-app /usr/share/nginx/html
