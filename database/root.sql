CREATE TABLE IF NOT EXISTS murmer_user(
    user_id bigserial not null,
    user_uuid uuid not null,
    username text not null,
    email text not null,
    email_normalized text not null,
    email_confirmation_code text,
    email_confirmed_at_time timestamptz,
    row_created_at_time timestamptz not null,
    salt bytea not null,
    hashed_pass bytea not null,
    pass_changed_at_time timestamptz not null,
    PRIMARY KEY(user_id),
    CONSTRAINT uc_user__user_uuid UNIQUE(user_uuid)
);

CREATE TABLE IF NOT EXISTS murmer_thread(
    thread_id bigserial not null,
    thread_uuid uuid not null,
    user_id bigint not null,
    thread_name text not null,
    content text not null,
    row_created_at_time timestamptz not null,
    last_modified_at_time timestamptz not null
);
