CREATE SCHEMA "murmur";
SET SCHEMA "murmur";

CREATE TABLE "user" (
    "user_id" bigserial NOT NULL,
    "user_uuid" uuid NOT NULL,
    "display_name" text NOT NULL,
    "email" text NOT NULL,
    "email_normalized" text NOT NULL,
    "email_confirmation_token" text,
    "email_confirmed_at" timestamptz,
    "created_at" timestamptz NOT NULL,
    "password" bytea NOT NULL,
    "password_changed_at" timestamptz NOT NULL,
    "password_reset_token" text,
    PRIMARY KEY("user_id"),
    CONSTRAINT "uc_user__user_uuid" UNIQUE("user_uuid")
);

CREATE TABLE "thread" (
    "thread_id" bigserial NOT NULL,
    "thread_uuid" uuid NOT NULL,
    "user_id" bigint NOT NULL,
    "thread_name" text NOT NULL,
    "content" text NOT NULL,
    "created_at" timestamptz NOT NULL,
    "modified_at" timestamptz NOT NULL
);

